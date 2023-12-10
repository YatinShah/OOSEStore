using System.Collections;
using System.Xml;

using OOSEStore.Models;

namespace OOSEStore.Iterators
{
    public class SaleItemsCollection : ICollection<SaleItem>
    {
        private readonly List<SaleItem> m_Items = [];
        public int Count => m_Items.Count;
        public bool IsReadOnly => false;

        public void Add(SaleItem item)
        {
            m_Items.Add(item);
        }

        public void Clear()
        {
            m_Items.Clear();
        }

        public bool Contains(SaleItem item)
        {
            return m_Items.Contains(item);
        }

        public void CopyTo(SaleItem[] array, int arrayIndex)
        {
            m_Items.CopyTo(array, arrayIndex);
        }

        public IEnumerator<SaleItem> GetEnumerator()
        {
            return m_Items.GetEnumerator();
        }

        public bool Remove(SaleItem item)
        {
            return m_Items.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void ToXml(XmlElement source)
        {
            foreach (var coupon in m_Items)
            {
                coupon.ToXml(source);
            }
        }

    }
}
