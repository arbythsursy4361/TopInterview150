public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int flag1 = 0, flag2 = 0, count = 0;
        int[] result = new int[m + n];
        while(flag1 < m && flag2 < n){
            if(nums1[flag1] < nums2[flag2]){
                result[count] = nums1[flag1];
                flag1++;
                count++;
            }
            else if(nums2[flag2] < nums1[flag1]){
                result[count] = nums2[flag2];
                flag2++;
                count++;
            }
            else{
                result[count] = nums1[flag1];
                flag1++;
                count++;
                result[count] = nums2[flag2];
                flag2++;
                count++;
            }
        }

        while(flag1 < m){
            result[count] = nums1[flag1];
            flag1++;
            count++;
        }
        while(flag2 < n){
            result[count] = nums2[flag2];
            flag2++;
            count++;
        }

        for(int i = 0; i < result.Length; i++){
            nums1[i] = result[i];
        }
    }
}
