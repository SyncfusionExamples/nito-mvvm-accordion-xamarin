using Nito.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AccordionXamarin
{
    public class ItemInfoRepository : INotifyPropertyChanged
    {
        #region Properties
        public ObservableCollection<ItemInfo> Info { get; set; }
        public IAsyncCommand LoadDataCommand { get; set; }
        #endregion

        #region Constructor
        public ItemInfoRepository()
        {
            LoadDataCommand = new AsyncCommand(ExecuteLoadData);
        }

        #endregion

        #region Methods

        private async Task ExecuteLoadData(object args)
        {
            var notifyTask = NotifyTask.Create(LoadData);
            if (notifyTask.IsCompleted)
            {
                Info = notifyTask.Result as ObservableCollection<ItemInfo>;
                OnPropertyChanged(nameof(Info));
            }
        }

        private async Task<ObservableCollection<ItemInfo>> LoadData()
        {
            var info = new ObservableCollection<ItemInfo>
            {
                new ItemInfo() { Name = "Cheese burger", Description = "Hamburger accompanied with melted cheese. The term itself is a portmanteau of the words cheese and hamburger. The cheese is usually sliced, then added a short time before the hamburger finishes cooking to allow it to melt." },
                new ItemInfo() { Name = "Veggie burger", Description = "Veggie burger, garden burger, or tofu burger uses a meat analogue, a meat substitute such as tofu, textured vegetable protein, seitan (wheat gluten), Quorn, beans, grains or an assortment of vegetables, which are ground up and formed into patties." },
                new ItemInfo() { Name = "Barbecue burger", Description = "Prepared with ground beef, mixed with onions and barbecue sauce, and then grilled. Once the meat has been turned once, barbecue sauce is spread on top and grilled until the sauce caramelizes." },
                new ItemInfo() { Name = "Chili burger", Description = "Consists of a hamburger, with the patty topped with chili con carne." }
            };
            return info;
        }
        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }

    public class ItemInfo
    {
        #region Properties
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion
    }
}

