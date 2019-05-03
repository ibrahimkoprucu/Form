using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FourCalculation.UI
{
    public class FormManager
    {
        private readonly Dictionary<Type, Form> _keyValuePairs;

        public FormManager()
        {
            this._keyValuePairs = new Dictionary<Type, Form>();
        }

        public T GetInstance<T>() where T : Form, new()
        {
            if (!_keyValuePairs.ContainsKey(typeof(T)))
            {
                var instance = new T();
                instance.FormClosed += delegate
                {
                    _keyValuePairs.Remove(typeof(T));
                    instance.Dispose();
                };
                _keyValuePairs.Add(typeof(T), instance);
            }

            return (T)_keyValuePairs[typeof(T)];
        }

        public void OpenForm(string operation)
        {
            MessageBox.Show(operation);
        }
    }
}