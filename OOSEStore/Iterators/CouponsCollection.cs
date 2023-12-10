using System.Collections;
using System.Xml;

using OOSEStore.Decorators;

namespace OOSEStore.Iterators
{
    public class CouponsCollection : ICollection<CouponDecorator>
    {
        private readonly List<CouponDecorator> m_Items = [];
        public int Count => m_Items.Count;
        public bool IsReadOnly => false;

        public void Add(CouponDecorator item)
        {
            m_Items.Add(item);
        }

        public void Clear()
        {
            m_Items.Clear();
        }

        public bool Contains(CouponDecorator item)
        {
            return m_Items.Contains(item);
        }

        public void CopyTo(CouponDecorator[] array, int arrayIndex)
        {
            m_Items.CopyTo(array, arrayIndex);
        }

        public IEnumerator<CouponDecorator> GetEnumerator()
        {
            return m_Items.GetEnumerator();
        }

        public bool Remove(CouponDecorator item)
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
