class Program {
    static void Main(string[] args) {
        
        var divider =  new IntegerDivision();
        divider.setTop(10);
        divider.setRHS(1);
        divider.DisplayResult();

        divider.setTop(0);
        divider.setRHS(100);
        divider.DisplayResult();

        divider.setTop(5);
        divider.setRHS(0);
        divider.DisplayResult();

        divider.setTop(25);
        divider.setRHS(5);
        divider.DisplayResult();
    }
}

class IntegerDivision {
    private int lhs = 1;
    private int rhs = 1;
    public int Result() {
        return lhs / rhs;
    }
    public int getTop(){
        return lhs;
    }
    public void setTop(int top){
        lhs = top;
    }
    public int getRHS(){
        return rhs;
    }
    public void setRHS(int top){
        if(top == 0){
            Console.WriteLine("Dividing by zero. Pick a different number");
            string ryan = Console.ReadLine();
            int newNum = int.Parse(ryan);
            rhs = newNum;
        }else{
            rhs = top;
        }
    }
    public void DisplayResult() {
        if(rhs == 0){
            Console.WriteLine("NO, Stop that");
        }else{
            var result = Result();
            Console.WriteLine($"{lhs} divided by {rhs} is {result}");
        } 
    }
}
