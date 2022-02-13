using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LabWork1CompModel
{
  public partial class Form1 : Form
  {
    private const int N = 2000;
    public static double[] numberArray;
    public static int _intervalCount;
    private static int _m;
    private static int _y0;
    private static int _y1;

    private static double Random()
    {
      int y = (_y0 + _y1) % _m;
      _y0 = _y1;
      _y1 = y;
      return (double)y / _m;
    }

    private static double[] ArrayFiller()
    {
      _m = 4096 * 4;
      _y0 = 3971;
      _y1 = 1013;
      double[] _array = new double[N];
      for (int i = 0; i < N; i++)
      {
        _array[i] = Random();
      }
      return _array;
    }


    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      numberArray = ArrayFiller();
    }

    private void button3_Click(object sender, EventArgs e)
    {

      int _listBoxCount = ArrayFiller().Count();
      for (int i = 0; i < N; i++)
      {
        listBox1.Items.Add(ArrayFiller()[i]);
      }

      /*chart1.ChartAreas[0].AxisX.Minimum = 0;
      chart1.ChartAreas[0].AxisX.Maximum = 1;
      chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 0.05;*/

      chart1.Series[0].Points.DataBindY(DrawHystogram());
      chart2.Series[0].Points.DataBindY(DrawStatFunction());
      
      /*chart1.ChartAreas[0].AxisX.Interval = 0.05;
      chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
      chart1.Series[0]["PixelPointWidth"] = "5";
      chart1.Series[0]["PixelPointPosition"] = "0";*/

    }

    private static double FindMathDelay()
    {
      double _mathDelay = 0;
      double _arrayNumberSumm = 0;

      for (int i = 0; i < N; i++)
      {
        _arrayNumberSumm += numberArray[i];
      }
      _mathDelay = _arrayNumberSumm / N;

      return _mathDelay;
    }

    private static double FindDispersion()
    {
      double _dispersion = 0;
      double _arrayNumberSummForDispersion = 0;

      for (int i = 0; i < N; i++)
      {
        _arrayNumberSummForDispersion += ((numberArray[i] - FindMathDelay()) * (numberArray[i] - FindMathDelay()));
      }
      _dispersion = _arrayNumberSummForDispersion / N;
      return _dispersion;
    }

    private static double FindSecondMoment()
    {
      double _math2Moment = 0;
      double _arraySquaresNumberSumm = 0;

      for (int i = 0; i < N; i++)
      {
        _arraySquaresNumberSumm += numberArray[i] * numberArray[i];
      }
      _math2Moment = _arraySquaresNumberSumm / N;

      return _math2Moment;
    }

    private static double FindThirdMoment()
    {
      double _math3Moment = 0;
      double _arraySquaresNumberSumm = 0;

      for (int i = 0; i < N; i++)
      {
        _arraySquaresNumberSumm += numberArray[i] * numberArray[i] * numberArray[i];
      }
      _math3Moment = _arraySquaresNumberSumm / N;

      return _math3Moment;
    }

    private void MatOjidanie_Click(object sender, EventArgs e)
    {
      textBox1.Text = FindMathDelay().ToString();
    }

    private void Dispersiya_Click(object sender, EventArgs e)
    {
      textBox2.Text = FindDispersion().ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox3.Text = FindSecondMoment().ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox4.Text = FindThirdMoment().ToString();
    }

    private static double[] DrawHystogram()
    {
      double[] _hystogramArray = new double[_intervalCount];
      double _averageValue = 0;
      for (int j = 0; j < _intervalCount; j++)
      {
        for (int i = 0; i < N; i++)
        {
          if (numberArray[i] > (j * ((double)1 /_intervalCount)) && numberArray[i] < ((j + 1) * ((double)1 / _intervalCount)))
          {
            _averageValue += 1;
          }
          
        }


        _hystogramArray[j] = _averageValue / N;
        _averageValue = 0;
      }

      return _hystogramArray;
    }

    private static double[] DrawStatFunction()
    {
      double[] _StatFunctionArray = new double[_intervalCount];
      double _averageValue = 0;

      for (int j = 0; j < _intervalCount; j++)
      {
        for (int i = 0; i < N; i++)
        {
          if (numberArray[i] > 0 && numberArray[i] < ((j + 1) * ((double)1 / _intervalCount)))
          {
            _averageValue += 1;
          }
        }
        _StatFunctionArray[j] = _averageValue / N;
        _averageValue = 0;
      }

      return _StatFunctionArray;
    }

    private void IntervalCount(object sender, EventArgs e)
    {
      if (textBox5.Text == "") { }
      else { _intervalCount = Convert.ToInt32(textBox5.Text); }
    }
  }
}
