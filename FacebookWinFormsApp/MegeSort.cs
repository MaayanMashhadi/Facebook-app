using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.strategy;

namespace BasicFacebookFeatures
{
    public class MegeSort
    {
        private static IComperer m_Comperer;

        public static void MainMerge(Album[] i_Albums, int left, int mid, int right)
        {
            Album[] temp = new Album[i_Albums.Length];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);
           
            while ((left <= eol) && (mid <= right))
            {
                if (m_Comperer.Comper(i_Albums[left].Count, i_Albums[mid].Count))
                    temp[pos++] = i_Albums[left++];
                else
                    temp[pos++] = i_Albums[mid++];
            }
            while (left <= eol)
                temp[pos++] = i_Albums[left++];
            while (mid <= right)
                temp[pos++] = i_Albums[mid++];
            for (i = 0; i < num; i++)
            {
                i_Albums[right] = temp[right];
                right--;
            }
        }

        public static void SortMerge(Album[] i_Albums, int left, int right, IComperer i_comper)
        {
            int mid;
            m_Comperer = i_comper;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(i_Albums, left, mid, i_comper);
                SortMerge(i_Albums, (mid + 1), right, i_comper);
                MainMerge(i_Albums, left, (mid + 1), right);
            }
        }
    }
}
