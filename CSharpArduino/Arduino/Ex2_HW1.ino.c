char chIn, ch[2];
int input = 0, answer = 0, min = 0, max = 100, i;

void setup(){
  Serial.begin(9600);
  randomSeed(analogRead(A0)); //給亂數值提供隨機種子
}

void loop(){
  min = 0;
  max = 100;
  input = 999;
  answer = random(min, max); //產生隨機亂數0~99
  Serial.println("Answer number: ");
  Serial.println(answer);
  while (input != answer){ //答案錯誤時重覆執行迴圈
    Serial.println("Range of answer: ");
    Serial.print(min);
    Serial.print(" to ");
    Serial.println(max);
    Serial.println("Enter two digit number: ");
    while (!Serial.available()){} //等待使用者輸入

    i = 0;
    memset(ch, 0, sizeof(ch)); //清空陣列
    while ((chIn = Serial.read()) != '\n') {
      if (chIn >= '0' && chIn <= '9' && i < 2) { //確保輸入的是1位或2位數字
        ch[i] = chIn;
        i++;
      }
    }
    input=atoi(ch); //字元陣列轉換成數值
    Serial.println(input);

    if (input != answer){ //未輸入正確數字,改變提示範圍
      if (input > min && input < answer){
        min = input;
      }
      else if (input < max && input > answer){
        max = input;
      };
    }
  }
  Serial.println("Correct, the answer is: "); //猜對了,顯示答案
  Serial.println(answer);
}