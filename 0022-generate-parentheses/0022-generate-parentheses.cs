public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        
        List<string> result = new();
        
        GenerateParenthesis(result, "", 0, 0, n);
        
        return result;
        
    }
    
    private void GenerateParenthesis(List<string> result, string s, int open, int close, int n){
        
        if (open == n && close == n){
            result.Add(s);
            return;
        }
        
        if (open < n){
            GenerateParenthesis(result, s + "(", open + 1, close, n);
        }
        
        if(close < open){            
            GenerateParenthesis(result, s + ")", open, close + 1, n);       
        }
    }
}