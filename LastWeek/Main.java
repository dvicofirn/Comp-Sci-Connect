import unit4.collectionsLib.*;

public class Main {
    public static Stack<Character> unzip(Stack<Item> S){
        Stack<Character> output = new Stack();
        Item currentItem;
        int currentNum;
        char currentChar;

        Stack<Item> temp = new Stack();
        while(!S.isEmpty()){
            currentItem=S.pop();
            currentNum=currentItem.getNum();
            if(currentNum>0){
                currentChar=currentItem.getTav();
                for(int i=0;i<currentNum;i++){
                    output.push(currentChar);
                }
            }
            temp.push(currentItem);
        }
        while(!temp.isEmpty()){
            S.push(temp.pop());
        }
        return output;
    }
    public static void main(String[] args) {
	// write your code here
    }
}
