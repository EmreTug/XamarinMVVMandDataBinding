using MVVMandDataBinding.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMandDataBinding.ViewModel
{
    public class MessageViewModel
    {
        public MessageViewModel()
        {
            addMessage = new Command(onAddMessage);
        }


        private ObservableCollection<Message> _mesage;
        public ObservableCollection<Message> Messages
        {
            get
            {
                if (_mesage == null)
                {
                    _mesage = new ObservableCollection<Message>();

                }
                return _mesage;
            }

            set
            {
                _mesage = value;
            }


        }



        
        ICommand addMessage;


        public ICommand AddMessage
        {
            get
            {
                return addMessage;
            }

            set
            {
                if (addMessage == null)
                    return;
                addMessage = value;
            }
        }
        private void onAddMessage(object param)
        {
            Entry entry = param as Entry;
            Messages.Add(new Message() { Text =entry.Text });
            entry.Text = "";
        }
      

    }
}
