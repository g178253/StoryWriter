using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryWriter.Core
{
    /// <summary>
    /// 表示目录。
    /// </summary>
    public sealed class TableOfContent : NotifyBase
    {
        /// <summary>
        /// 获取目录的集合。
        /// </summary>
        public ICollection<Element> Table { get; } = new ObservableCollection<Element>();

        private Element m_Item;
        /// <summary>
        /// 当前选中的目录。
        /// </summary>
        public Element Item { get => m_Item; set { m_Item = value; OnChanged(); } }
    }
}
