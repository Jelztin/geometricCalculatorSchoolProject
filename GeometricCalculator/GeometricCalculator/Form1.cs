using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricCalculator
{
    public partial class Form1 : Form
    {
        private Log log;
        private Calculate calc;
        private Print print;
        public Form1()
        {
            InitializeComponent();
            log = new Log();
            calc = new Calculate();
            print = new Print();
        }

        private void calculate_click(object sender, EventArgs e)
        {
            try {
                switch (FigureTypeSelector.Text)
                {
                    case "Box":
                        Result.Text = calc.calculateResult(
                            new Box(
                                double.Parse(v1.Text),
                                double.Parse(v2.Text),
                                double.Parse(v3.Text)
                                ),
                            selectOperandType(Operation.Text)
                            );
                        log.log(FigureTypeSelector.Text, selectOperandType(Operation.Text).ToString(), Result.Text);
                        break;
                    case "Square":
                        Result.Text = calc.calculateResult(
                            new Square(
                                double.Parse(v1.Text),
                                double.Parse(v2.Text)
                                ),
                            selectOperandType(Operation.Text)
                            );
                        log.log(FigureTypeSelector.Text, selectOperandType(Operation.Text).ToString(), Result.Text);
                        break;
                    default:
                        Result.Text = "Operation not supported";
                        break;
                }
            } catch
            {
                Result.Text = "Operation not supported!";
            }
        }

        private OperationType.operationType selectOperandType(string text)
        {
            return OperationType.getOperationType(text);
        }

        private void PrintLog_Click(object sender, EventArgs e)
        {
            print.printLog();
        }
    }
}
