﻿using System.Collections.Generic;
using System.Linq;

namespace StoryWriter.Core
{
    /// <summary>
    /// 表示容器。
    /// </summary>
    public sealed class Container : Element
    {
        /// <summary>
        /// 获取子元素的集合。
        /// </summary>
        private readonly ICollection<Element> m_Children = new List<Element>();

        /// <summary>
        /// 获取元素的值。
        /// </summary>
        public override dynamic Value { get => m_Children; }
        /// <summary>
        /// 获取或设置容器的子元素。
        /// </summary>
        public Element Child { get; set; } = Null.Instance;

        /// <summary>
        /// 添加元素。
        /// </summary>
        /// <param name="element">要添加的元素。</param>
        public void Add(Element element)
        {
            if (element != null)
            {
                Child = element;
                m_Children.Add(element);
            }
        }

        /// <summary>
        /// 移除元素。
        /// </summary>
        /// <param name="id">要移除的元素的编号。</param>
        public void Remove(int id)
        {
            var i = m_Children.FirstOrDefault(o => o.Id == id);
            if (i != null)
            {
                Child = Null.Instance;
                m_Children.Remove(i);
            }
        }
    }
}
