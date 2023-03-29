int sensorPin = A5; // select the input pin
int ledPin = 12; // select the pin for the LED
int sensorValue = 0; // variable to store the value coming from the sensor

bool set_to_default = true;
int check_value;
int default_value;

void setup () { // setting up the program and allow me to read out the adruino
pinMode (ledPin, OUTPUT);
Serial.begin (9600);
}

void loop () {  
sensorValue = analogRead (sensorPin);
delay (sensorValue);
Serial.println (sensorValue, DEC);

if(set_to_default == true){ // setting a default value for the program
delay(sensorValue);
default_value = sensorValue;
set_to_default = false;
}

check_value = default_value - sensorValue; // a function to check if its close to a object with a magnet
check_value = abs(check_value); // converts the value to a positive number
if(check_value >= 5){  // Giving it range so that it won't go off to quickly 
  Serial.println("magnet is close by");
  digitalWrite (ledPin, HIGH); 
  delay (sensorValue);
}
else digitalWrite(ledPin, LOW);
delay (sensorValue);
}

