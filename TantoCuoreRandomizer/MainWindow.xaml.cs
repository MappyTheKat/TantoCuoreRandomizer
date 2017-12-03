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
        private List<Maid> OriginalMaids = new List<Maid>();
        private List<Maid> ExpandingHouseMaids = new List<Maid>();
        private List<Maid> RomanticVacationMaids = new List<Maid>();
        private List<Maid> OktoberfestMaids = new List<Maid>();
        private List<Maid> WinterRomanceMaids = new List<Maid>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetMaids()
        {
            OriginalMaids.Clear();
            ExpandingHouseMaids.Clear();
            RomanticVacationMaids.Clear();
            OktoberfestMaids.Clear();
            WinterRomanceMaids.Clear();
        }

        public void OnRandomizeButtonPressed(object sender, EventArgs e)
        {
            bool IsOriginalInclude = true;
            ///
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

    public struct Maid
    {
        Expansion Expansion;
        string Name;
        int EmployCost;

        public Maid(Expansion expansion, string name, int employcost)
        {
            Expansion = expansion;
            Name = name;
            EmployCost = employcost;
        }
    }
}
