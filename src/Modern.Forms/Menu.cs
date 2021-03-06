﻿using System;
using System.Drawing;
using System.Linq;

namespace Modern.Forms
{
    public class Menu : MenuBase
    {
        public new static ControlStyle DefaultStyle = new ControlStyle (Control.DefaultStyle,
          (style) => {
              style.BackgroundColor = Theme.NeutralGray;
          });

        public override ControlStyle Style { get; } = new ControlStyle (DefaultStyle);

        public Menu ()
        {
            Dock = DockStyle.Top;
        }

        protected override void OnDeselected (EventArgs e)
        {
            base.OnDeselected (e);

            Deactivate ();
        }

        protected override Size DefaultSize => new Size (600, 28);

        protected override bool IsTopLevelMenu => true;

        protected override void LayoutItems ()
        {
            StackLayoutEngine.HorizontalExpand.Layout (ClientRectangle, Items.Cast<ILayoutable> ());
        }

        protected override void OnHoverChanged (MenuItem? oldItem, MenuItem? newItem)
        {
            if (IsActivated && newItem != null)
                SelectedItem = newItem;
        }
    }
}
