using MVVM_Reg.DataAccessLayer;
using MVVM_Reg.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Reg.ViewModel
{
    public class MainWindowViewModel
    {
        private ObservableCollection<UserReg> _users;
        private DataStorage ds = new DataStorage();
        public MainWindowViewModel()
        {
            Users = new ObservableCollection<UserReg>();
            Users= ds.Load();

        }
    public ObservableCollection<UserReg> Users
    {
        get
        {
            return _users;
        }
        set
        {
            _users = value;
        }
    }

}
}
