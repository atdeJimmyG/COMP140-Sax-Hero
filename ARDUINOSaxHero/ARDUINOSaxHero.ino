int CNYPin = A1;
int buttonPin01 = 12;
int buttonPin02 = 11;
int buttonPin03 = 10;
int buttonPin04 = 9;

void setup() {
  Serial.begin(9600);
  
  pinMode(buttonPin01, INPUT);
  pinMode(buttonPin02, INPUT);
  pinMode(buttonPin03, INPUT);
  pinMode(buttonPin04, INPUT);
 
  

}

void loop() {
  Serial.println(analogRead(CNYPin));
  delay(50);
  //Read state of pushbutton value
  buttonState1 = digitalRead(buttonPin1);
  buttonState2 = digitalRead(buttonPin2);
  buttonState3 = digitalRead(buttonPin3);
  buttonState4 = digitalRead(buttonPin4);

  //check if button is pressed
  //if pressed send output
  if(buttonState1 = HIGH){
    Serial.write(1);
    Serial.flush();
    }
  if(buttonState2 = HIGH){
    Serial.write(2);
    Serial.flush();
    }
  if(buttonState3 = HIGH){
    Serial.write(3);
    Serial.flush();
    }
  if(buttonState4 = HIGH){
    Serial.write(4);
    Serial.flush();
    }
    
}
