using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DgvPitDepth
{
    public partial class Form1 : Form
    {
        // 화면 관련 객체
        FFSPvCsPtSp ffsPvCsPtSp = new FFSPvCsPtSp();

        List<string> LocationList = new List<string> { "Same", "Opposite" };

        public Form1()
        {
            InitializeComponent();
        }

        public void SetUpDataGridView()
        {
            // 데이터 그리드 뷰를 초기화한다.
            dgvPitDepth.Rows.Clear();

            // 콤보박스를 정의한다.
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Location (Same/Opposite side with designated part)";
            comboBoxColumn.Name = "Location";

            for (int i = 0; i < LocationList.Count; i++)
            {
                comboBoxColumn.Items.AddRange(LocationList[i]);
            }

            // 마지막 열을 정의한다. 
            DataGridViewTextBoxColumn outputTxtBox = new DataGridViewTextBoxColumn();
            outputTxtBox.HeaderText = "d <= (D*tc)^0.5 Satisfaction";
            outputTxtBox.Name = "Satisfaction";
            outputTxtBox.ReadOnly = true;

            // 컬럼 헤더를 추가한다.
            dgvPitDepth.Columns.Add("column0", "");
            dgvPitDepth.Columns.Add("column1", "Pitting 깊이 (mm)");
            dgvPitDepth.Columns.Add(comboBoxColumn);
            dgvPitDepth.Columns.Add("column3", "Pitting Diameter(mm)");
            dgvPitDepth.Columns.Add(outputTxtBox);

            ffsPvCsPtSp.RowNum = Convert.ToInt32(nudRow1116.Value);  // 행의 개수

            // 첫 번째 열을 추가한다.
            for (int i = 0; i < ffsPvCsPtSp.RowNum; i++)
            {
                dgvPitDepth.Rows.Add("측정값" + (i + 1).ToString());
            }

            // 마지막 행 제거
            dgvPitDepth.AllowUserToAddRows = false;
        }

        private void nudRow1116_ValueChanged(object sender, EventArgs e)
        {
            SetUpDataGridView();
        }

        private void btnCalc1116_Click(object sender, EventArgs e)
        {
            GetData();

            ffsPvCsPtSp = Formula.GetQFactor(ffsPvCsPtSp);
        }

        public void GetData()
        {
            SortedList<int, object[]> Values = new SortedList<int, object[]>(); // 사용자가 입력한 모든 값
            int COLNUM = 4; // 열의 개수
            object[] inputValue;

            // 사용자가 입력한 값을 초기화한다.
            ffsPvCsPtSp.Values.Clear();

            // 사용자가 입력한 모든 값을 구한다.
            // pitting 깊이를 구한다.
            for (int i = 0; i < ffsPvCsPtSp.RowNum; i++)
            {
                inputValue = new object[COLNUM - 1]; // 사용자가 한 줄에 입력한 값들, 맨 마지막 열에 판별 결과를 출력하므로 1을 뺐다.

                for (int j = 0; j < COLNUM - 1; j++) // 맨 마지막 열에 판별 결과를 출력하므로 1을 뺐다.
                {
                    inputValue[j] = (dgvPitDepth.Rows[i].Cells[j + 1].Value);
                }

                ffsPvCsPtSp.Values.Add(i, inputValue);
            }

        }
    }
}
