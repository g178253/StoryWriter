namespace StoryWriter.Core
{
    /// <summary>
    /// 表示空元素。
    /// </summary>
    public sealed class Null : Element
    {
        private Null() { } // 单例模式。

        /// <summary>
        /// 获取空元素的唯一实例。
        /// </summary>
        public static Null Instance { get; } = new Null();

        /// <summary>
        /// 获取元素编号。
        /// </summary>
        public override int Id { get => -1; }
        /// <summary>
        /// 获取元素的键。
        /// </summary>
        public override dynamic Key { get => string.Empty; }
        /// <summary>
        /// 获取元素的值。
        /// </summary>
        public override dynamic Value { get => string.Empty; }
    }
}
