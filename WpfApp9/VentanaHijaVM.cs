﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9
{
    class VentanaHijaVM : ObservableRecipient
    {
        private int contador;

        public int Contador
        {
            get { return contador; }
            set { SetProperty(ref contador, value); }
        }
¡
        public VentanaHijaVM()
        {
            Contador = WeakReferenceMessenger.Default.Send<ValorActualRequestMessage>();

            WeakReferenceMessenger.Default.Register<ValorActualChangedMessage>(this, (r, m) =>
            {
                Contador = m.Value;
            });
        }
    }
}
