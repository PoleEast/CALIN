using System;
using System.Drawing;
using System.Windows.Forms;

namespace CALIN.Controls
{
    public class PictureEvent : PictureBox
    {
        private Image _image;
        // 自定义事件
        public event EventHandler ImageChanged;
        public PictureEvent()
        {
            // 在构造函数中为事件赋初值
            ImageChanged = null;
        }

        // 自定义的 Image 属性，带有事件
        public new Image? Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnImageChanged(EventArgs.Empty); // 触发事件
                base.Image = value; // 设置基类的 Image 属性
            }
        }

        // 触发事件的方法
        protected virtual void OnImageChanged(EventArgs e)
        {
            EventHandler eventHandler = ImageChanged;
            ImageChanged?.Invoke(this, e);
        }
    }
}
