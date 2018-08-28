using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace TantoCuoreRandomizer
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private List<Maid> OriginalMaids = new List<Maid>();
        private List<Maid> ExpandingHouseMaids = new List<Maid>();
        private List<Maid> RomanticVacationMaids = new List<Maid>();
        private List<Maid> OktoberfestMaids = new List<Maid>();
        private List<Maid> WinterRomanceMaids = new List<Maid>();
        private List<Maid> ExtraMaids = new List<Maid>(); // 크레센트 자매 하우스룰을 위한 추가 덱세팅

        public MainWindowViewModel()
        {
            // 덱 세팅 (하드코딩)

            // 본판(오리지널)
            OriginalMaids.Add(new Maid(Expansion.Original, "루쥬 크레센트", 2));
            OriginalMaids.Add(new Maid(Expansion.Original, "비올라 크레센트", 2));
            OriginalMaids.Add(new Maid(Expansion.Original, "애슬 크레센트", 2));
            OriginalMaids.Add(new Maid(Expansion.Original, "사프란 빌지니", 3));
            OriginalMaids.Add(new Maid(Expansion.Original, "클레르 산=쥬스트", 3));
            OriginalMaids.Add(new Maid(Expansion.Original, "카가리 이치노미야", 3));
            OriginalMaids.Add(new Maid(Expansion.Original, "일라이자 로즈워터", 3));
            OriginalMaids.Add(new Maid(Expansion.Original, "모완느 드 르페블", 4));
            OriginalMaids.Add(new Maid(Expansion.Original, "쥬느비에브 드비니", 4));
            OriginalMaids.Add(new Maid(Expansion.Original, "에스키누 포레", 4));
            OriginalMaids.Add(new Maid(Expansion.Original, "네나 와일더", 5));
            OriginalMaids.Add(new Maid(Expansion.Original, "나츠미 후지카와", 5));
            OriginalMaids.Add(new Maid(Expansion.Original, "티나리스 토렌트", 5));
            OriginalMaids.Add(new Maid(Expansion.Original, "세인즈베리 록우드", 5));
            OriginalMaids.Add(new Maid(Expansion.Original, "오필리아 그레일", 6));
            OriginalMaids.Add(new Maid(Expansion.Original, "아니스 그리나비", 7));

            // 하우스 룰을 위한 엑스트라 세팅
            ExtraMaids.Add(new Maid(Expansion.Original, "루쥬 크레센트", 2));
            ExtraMaids.Add(new Maid(Expansion.Original, "비올라 크레센트", 2));
            ExtraMaids.Add(new Maid(Expansion.Original, "애슬 크레센트", 2));

            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "리리코 히이라기", 2, ExtraSetting.Building));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "포리느 듀몬", 2));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "그레이스 솔즈베리", 2));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "스즈나 카미카와", 2));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "펠리시티 혼", 3));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "라일락 호크윈드", 3));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "피리스 럼레이", 3));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "루틸 델=살", 3));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "에밀리 레이먼드", 4, ExtraSetting.Building));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "빅토리아 칼데란", 4, ExtraSetting.Building));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "아마렛트 루나르", 5));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "도미노 보나파르트", 4));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "레네 R 류세크", 5));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "프란신 바르비에", 5));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "카리욘 판돌", 5));
            ExpandingHouseMaids.Add(new Maid(Expansion.ExpandingHouse, "티파니 와이즈", 7));

            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "노네트 소이유", 2));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "히아신스 애로우", 2, ExtraSetting.Reminiscence));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "발렌시아 프레트르", 3));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "에비타 카탈라", 3));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "제르메느 마레", 3));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "마가렛타 토렌트", 3));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "다프네 코라이유", 3));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "로미나 보우트린", 4));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "피이 프림로즈", 4));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "치나츠 코오리야마", 4));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "리야 나라가시", 4));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "카르디나 엘리", 4));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "신시아 레이크스", 5));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "플로렌스 스프링", 5));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "리디아 레온", 5));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "클로린드 씨", 6));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "로라", 6));
            RomanticVacationMaids.Add(new Maid(Expansion.RomanticVacation, "프리다 비엔토", 7));

            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "니콜 슈미그", 2));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "파울라 라우덴버그", 2));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "카오리 하마사키", 3));
            // 우테는 좀 애매한데 알콜에 영향은 받는데 맥주를 얻게할 방법은 없음(...)
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "우테 크롬바흐", 3));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "에일린 해머슈미트", 3));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "레나타 아벤드로스", 3));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "안나 하르트만", 3));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "키리카 폰 하이드만", 4));
            // 줄리아도 맥주 덱을 볼 기능은 있는데 맥주를 얻는 방법은 없어서.. 그냥 2카드 1구매라고 생각하면 좀 구리긴 함
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "줄리아 쿤스테르", 4));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "사라 레온하르트", 4));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "지나 케르스텐", 4, ExtraSetting.Beer));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "나디야 케르스텐", 5, ExtraSetting.Beer));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "노라 모르겐슈테른", 5));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "토니 달링", 5));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "헤르미나 바움", 6));
            OktoberfestMaids.Add(new Maid(Expansion.Oktoberfest, "엘자 라인마이어", 7));

            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "더모트 게린", 8, ExtraSetting.Drama));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "미카엘라 피델리티", 7));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "메노우 타테히라", 6));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "서니 크로스카렌트", 6));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "시시도 쿠로가네", 5));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "단테 가니에", 5));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "킴벌리 에반", 4));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "브누와 입센", 4));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "셜리 폴록", 4));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "허비 포츠", 3, ExtraSetting.Couple));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "엘리자베스 코란", 3, ExtraSetting.Couple));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "지미 해리스턴", 3));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "니콜라스 가리발디", 3));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "아네모네 세이야", 3));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "샨티 벨", 1));
            WinterRomanceMaids.Add(new Maid(Expansion.WinterRomance, "키나 솔스티아", 2));
        }

        private bool isOriginalInclude = true;
        public bool IsOriginalInclude
        {
            get
            {
                return isOriginalInclude;
            }
            set
            {
                isOriginalInclude = value;
                OnPropertyChnaged("IsOriginalInclude");
            }
        }

        private bool isExpandingHouseInclude = true;
        public bool IsExpandingHouseInclude
        {
            get
            {
                return isExpandingHouseInclude;
            }
            set
            {
                isExpandingHouseInclude = value;
                OnPropertyChnaged("isExpandingHouseInclude");
            }
        }

        private bool isRomanticVacationInclude = true;
        public bool IsRomanticVacationInclude
        {
            get
            {
                return isRomanticVacationInclude;
            }
            set
            {
                isRomanticVacationInclude = value;
                OnPropertyChnaged("isRomanticVacationInclude");
            }
        }

        private bool isOktoberfestInclude = true;
        public bool IsOktoberfestInclude
        {
            get
            {
                return isOktoberfestInclude;
            }
            set
            {
                isOktoberfestInclude = value;
                OnPropertyChnaged("isOktoberfestInclude");
            }
        }

        private bool isWinterRomanceInclude = true;
        public bool IsWinterRomanceInclude
        {
            get
            {
                return isWinterRomanceInclude;
            }
            set
            {
                isWinterRomanceInclude = value;
                OnPropertyChnaged("isWinterRomanceInclude");
            }
        }

        private bool isExtraDeckRuleInclude = false;
        public bool IsExtraDeckRuleInclude
        {
            get
            {
                return isExtraDeckRuleInclude;
            }
            set
            {
                isExtraDeckRuleInclude = value;
                OnPropertyChnaged("isExtraDeckRuleInclude");
            }
        }

        public void Randomize()
        {
            OutputMaids.Clear();

            List<Maid> WholePool = new List<Maid>();

            if (IsOriginalInclude)
            {
                WholePool.AddRange(OriginalMaids);
            }

            if (IsExpandingHouseInclude)
            {
                WholePool.AddRange(ExpandingHouseMaids);
            }

            if (IsRomanticVacationInclude)
            {
                WholePool.AddRange(RomanticVacationMaids);
            }

            if (IsOktoberfestInclude)
            {
                WholePool.AddRange(OktoberfestMaids);
            }

            if (IsWinterRomanceInclude)
            {
                WholePool.AddRange(WinterRomanceMaids);
            }

            Random random = new Random();
            for (int count = 0; count < 10; count++)
            {
                int randomvalue = random.Next() % WholePool.Count;
                Maid selectedMaid = WholePool.ElementAt(randomvalue);
                OutputMaids.Add(selectedMaid);
                WholePool.RemoveAt(randomvalue);
            }

            //크레센트 자매 추가 덱에서 크레센트 자매를 뽑는다.
            if (IsExtraDeckRuleInclude)
            {
                if (OutputMaids.Any(maid => ExtraMaids.Any(extramid => extramid.Name == maid.Name)))
                {
                    //이미 뽑혀있는 크레센트 자매들을 추가 덱에서 제외한다.
                    ExtraMaids.RemoveAll(extramid => OutputMaids.Any(maid => extramid.Name == maid.Name));

                    int extraCount = ExtraMaids.Count;

                    Random random2 = new Random();
                    Random random3 = new Random();
                    for (int extraTries = 0; extraTries < extraCount; extraTries++)
                    {
                        int randomValue2 = random2.Next() % 3;
                        if (randomValue2 > extraTries)
                        {
                            int randomValue3 = random3.Next() % ExtraMaids.Count;
                            Maid selectedExtramaid = ExtraMaids.ElementAt(randomValue3);
                            OutputMaids.Add(selectedExtramaid);
                            ExtraMaids.RemoveAt(randomValue3);
                        }
                    }
                }
            }
        }

        public ObservableCollection<Maid> OutputMaids = new ObservableCollection<Maid>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChnaged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
