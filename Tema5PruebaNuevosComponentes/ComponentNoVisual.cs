using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5PruebaNuevosComponentes
{
    public partial class ComponentNoVisual : Component
    {
        public ComponentNoVisual()
        {
            InitializeComponent();
        }

        public ComponentNoVisual(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
