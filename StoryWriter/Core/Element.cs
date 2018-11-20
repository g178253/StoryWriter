namespace StoryWriter.Core
{
    /// <summary>
    /// 表示任何元素。
    /// </summary>
    public class Element : NotifyBase
    {
        /// <summary>
        /// 获取或设置元素编号。
        /// </summary>
        public virtual int Id { get; set; }

        private dynamic m_Key;
        /// <summary>
        /// 获取或设置元素的键。
        /// </summary>
        public virtual dynamic Key { get => m_Key; set { m_Key = value; OnChanged(); } }

        private dynamic m_Value;
        /// <summary>
        /// 获取或设置元素的值。
        /// </summary>
        public virtual dynamic Value { get => m_Value; set { m_Value = value; OnChanged(); } }
    }
}
