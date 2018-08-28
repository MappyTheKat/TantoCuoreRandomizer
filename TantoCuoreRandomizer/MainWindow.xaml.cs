using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TantoCuoreRandomizer
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel ViewModel = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModel;
            this.xListViewResult.ItemsSource = ViewModel.OutputMaids;
		}

        public void OnRandomizeButtonPressed(object sender, EventArgs e)
        {
            ViewModel.Randomize();
        }
    }
}

public enum Expansion
{
    Original,
    ExpandingHouse,
    RomanticVacation,
    Oktoberfest,
    WinterRomance
}

// 하우스 룰용 추가 세팅 확인용.
// 반드시 넣어야하는 경우만 체크하게 되어있음.
public enum ExtraSetting
{
    None,
    Building,
    Reminiscence,
    Beer,
    Couple,
    Drama
}

public struct Maid
{
    public Expansion Expansion;
    public string ExpansionName
    {
        get
        {
            return Expansion.ToString("F");
        }
    }
    public string Name { get; set; }
    public int EmployCost { get; set; }

    public ExtraSetting ExtraSetting;
    public string ExtraSettingString
    {
        get
        {
            return ExtraSetting.ToString("F");
        }
    }

    public Maid(Expansion expansion, string name, int employcost)
        : this(expansion, name, employcost, ExtraSetting.None)
    {

    }

    public Maid(Expansion expansion, string name, int employcost, ExtraSetting extrasetting)
    {
        Expansion = expansion;
        Name = name;
        EmployCost = employcost;
        ExtraSetting = extrasetting;
    }
}
