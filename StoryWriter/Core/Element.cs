namespace StoryWriter.Core
{
    /// <summary>
    /// 表示任何元素。
    /// </summary>
    public class Element
    {
        /// <summary>
        /// 获取或设置元素编号。
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// 获取或设置元素的键。
        /// </summary>
        public virtual dynamic Key { get; set; }
        /// <summary>
        /// 获取或设置元素的值。
        /// </summary>
        public virtual dynamic Value { get; set; }
    }
}
