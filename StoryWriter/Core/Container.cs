using System.Collections.Generic;
using System.Linq;

namespace StoryWriter.Core
{
    /// <summary>
    /// 表示容器。
    /// </summary>
    public sealed class Container : Element
    {
        /// <summary>
        /// 获取或设置容器的子元素。
        /// </summary>
        public Element Child { get; set; } = Null.Instance;

        /// <summary>
        /// 获取子元素的集合。
        /// </summary>
        public ICollection<Element> Children { get; } = new List<Element>();

        /// <summary>
        /// 添加元素。
        /// </summary>
        /// <param name="element">要添加的元素。</param>
        public void Add(Element element)
        {
            if (element != null)
            {
                Child = element;
                Children.Add(element);
            }
        }

        /// <summary>
        /// 移除元素。
        /// </summary>
        /// <param name="id">要移除的元素的编号。</param>
        public void Remove(int id)
        {
            var i = Children.FirstOrDefault(o => o.Id == id);
            if (i != null)
            {
                Child = Null.Instance;
                Children.Remove(i);
            }
        }
    }
}
