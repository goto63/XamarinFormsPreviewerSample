using System;
using System.Collections.ObjectModel;

namespace XamarinFormsPreviewerSample
{
    public class MonkeysViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; } = new ObservableCollection<Monkey>();

        public MonkeysViewModel()
        {
            this.Monkeys.Add(new Monkey { Name = "エンペラータマリン", Image = "EmperorTamarin.jpg", Location = "南アフリカ" });
            this.Monkeys.Add(new Monkey { Name = "ゴールデンライオンタマリン", Image = "GoldenLionTamarin.jpg", Location = "ブラジル" });
            this.Monkeys.Add(new Monkey { Name = "手長猿", Image = "Tenagazaru.jpg", Location = "インド" });
        }

        public int MonkeyCount => Monkeys.Count;
    }
}

