using System.Windows;
using System.Windows.Controls;

namespace StoryWriter.UI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Core.TableOfContent m_table;// 目录。
        public MainWindow()
        {
            InitializeComponent();

            m_table = new Core.TableOfContent();
            var c = Core.Container.Default("小说");
            m_table.Item = c;
            m_table.Table.Add(c);

            TableOfContents.ItemsSource = m_table.Table;
        }

        #region 目录

        // 设置当前选中的目录。
        private void TableOfContents_Selected(object sender, RoutedEventArgs e)
        {
            m_table.Item = GetElement<Core.Element>(e.OriginalSource);
        }

        /// <summary>
        /// 从指定对象中，获取目录元素。
        /// </summary>
        /// <typeparam name="T">目录元素的类型。</typeparam>
        /// <param name="src">源对象。</param>
        /// <returns>如果获取成功，返回该对象；否则返回类型默认值。</returns>
        private T GetElement<T>(object src) where T : Core.Element
        {
            if (src == null
                || !(src is TreeViewItem tv)
                || !(tv.DataContext is T elem))
                return default(T);
            return elem;
        }

        // 添加目录。
        private void AddContainer_Click(object sender, RoutedEventArgs e)
        {
            AddElement(m_table.Item, new Core.Container { Key = "第1卷" });
        }

        // 添加章节。
        private void AddElement_Click(object sender, RoutedEventArgs e)
        {
            AddElement(m_table.Item, new Core.Element { Key = "第1章" });
        }

        /// <summary>
        /// 添加新目录。
        /// </summary>
        /// <param name="selectedItem">选中的目录。</param>
        /// <param name="toAdd">要添加的目录。</param>
        private void AddElement(Core.Element selectedItem, Core.Element toAdd)
        {
            if (selectedItem is Core.Container c)
                c.Add(toAdd);
        }

        #endregion
    }
}
