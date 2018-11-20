using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StoryWriter.Core
{
    /// <summary>
    /// 属性通知的基类。
    /// </summary>
    public abstract class NotifyBase : INotifyPropertyChanged
    {
        /// <summary>
        /// 属性更改事件。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 属性更改时调用。
        /// </summary>
        /// <param name="name">属性名。</param>
        protected virtual void OnChanged([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
