 
 TreeNode root1 = new TreeNode(1);
    root1.left = new TreeNode(2);
    root1.right = new TreeNode(3);
    root1.left.left = new TreeNode(4);
    root1.left.right = new TreeNode(5);
    root1.right.right = new TreeNode(6);

    TreeNode root2 =  new TreeNode(4);
    root2.left =  new TreeNode(1);
    root2.right =  new TreeNode(7);
    root2.left.left =  new TreeNode(3);
    root2.right.left =  new TreeNode(2);
    root2.right.right =  new TreeNode(6);

 internal class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
static TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
       if(root1==null){
        return root2;
       }
       if(root2==null)
       return root1;
        root1.val+=root2.val;
        root1.left = MergeTrees(root1.left,root2.left);
        root1.right = MergeTrees(root1.right,root2.right);
        return root1;
}
}
