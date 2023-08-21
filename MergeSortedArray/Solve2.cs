public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {        
        int position = m + n - 1, p1 = m - 1, p2 = n - 1;
        while(p2 >= 0){
            if(p1 >= 0 && nums1[p1] > nums2[p2]){
                nums1[position--] = nums1[p1--];
            }
            else{
                nums1[position--] = nums2[p2--];
            }
        }
    }
}
