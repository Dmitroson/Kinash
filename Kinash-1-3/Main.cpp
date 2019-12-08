#include <iostream>
#include <cmath>

using namespace std;

class PairOfIntegers {
protected:
	int FirstIntegerNumber, SecondIntegerNumber;
public:
	PairOfIntegers() {
		FirstIntegerNumber = 0;
		SecondIntegerNumber = 0;
	}

	PairOfIntegers(int firstNumber, int secondNumber) {
		FirstIntegerNumber = firstNumber;
		SecondIntegerNumber = secondNumber;
	}

	~PairOfIntegers() { }
	
	int GetFirstNumber() {
		return FirstIntegerNumber;
	}

	void SetFirstNumber(int firstNumber) {
		FirstIntegerNumber = firstNumber;
	}

	int GetSecondNumber() {
		return SecondIntegerNumber;
	}

	void SetSecondNumber(int secondNumber) {
		SecondIntegerNumber = secondNumber;
	}

	friend istream& operator >> (istream&, PairOfIntegers&);
	friend ostream& operator << (ostream&, PairOfIntegers&);

	virtual PairOfIntegers CompareNumbers(PairOfIntegers& secondPair) {
		if ((this->FirstIntegerNumber == secondPair.FirstIntegerNumber) && (this->SecondIntegerNumber == secondPair.SecondIntegerNumber)) {
			cout << "Pairs are equal\n";
			return *this;
		}

		if (this->FirstIntegerNumber > secondPair.FirstIntegerNumber) 
			return *this; 
		
		if((this->FirstIntegerNumber == secondPair.FirstIntegerNumber) && (this->SecondIntegerNumber > secondPair.SecondIntegerNumber)) 
			return *this;
		
		if (this->FirstIntegerNumber < secondPair.FirstIntegerNumber) 
			return secondPair;
		
		if ((this->FirstIntegerNumber == secondPair.FirstIntegerNumber) && (this->SecondIntegerNumber < secondPair.SecondIntegerNumber))
			return secondPair;
	}
};

class PairOfDoubles : public PairOfIntegers {
protected:
	double FirstFractionalPart, SecondFractionalPart;
public:
	PairOfDoubles() {
		FirstFractionalPart = 0;
		SecondFractionalPart = 0;
	}

	PairOfDoubles(int firstIntegerNumber, double firstFractionalPart, int secondIntegerNumber, double secondFractionalPart) 
		: PairOfIntegers(firstIntegerNumber, secondIntegerNumber){
		FirstFractionalPart = firstFractionalPart;
		SecondFractionalPart = secondFractionalPart;
	}
	
	double GetFirstFractionalPart() {
		return FirstFractionalPart;
	}

	void SetFirstFractionalPart(double fractional) {
		FirstFractionalPart = fractional;
	}

	double GetSecondFractionalPart() {
		return SecondFractionalPart;
	}

	void SetSecondFractionalPart(double fractional) {
		SecondFractionalPart = fractional;
	}

	PairOfDoubles CompareNumbers(PairOfDoubles& secondPair) {
		if ((this->FirstIntegerNumber + FirstFractionalPart == secondPair.FirstIntegerNumber + secondPair.FirstFractionalPart) &&
			(this->SecondIntegerNumber + SecondFractionalPart == secondPair.SecondIntegerNumber + secondPair.SecondFractionalPart)) {
			cout << "Pairs are equal\n";  
			return *this;
		}

		if (this->FirstIntegerNumber + FirstFractionalPart > secondPair.FirstIntegerNumber + secondPair.FirstFractionalPart)
			return *this;

		if ((this->FirstIntegerNumber + FirstFractionalPart == secondPair.FirstIntegerNumber + secondPair.FirstFractionalPart) 
			&& (this->SecondIntegerNumber + SecondFractionalPart > secondPair.SecondIntegerNumber + secondPair.SecondFractionalPart))
			return *this;
		
		if (this->FirstIntegerNumber + FirstFractionalPart < secondPair.FirstIntegerNumber + secondPair.FirstFractionalPart)
			return secondPair;

		if ((this->FirstIntegerNumber + FirstFractionalPart == secondPair.FirstIntegerNumber + secondPair.FirstFractionalPart) && 
			(this->SecondIntegerNumber + SecondFractionalPart < secondPair.SecondIntegerNumber + secondPair.SecondFractionalPart))
			return secondPair;
	}

	friend istream& operator >> (istream&, PairOfDoubles&);
	friend ostream& operator << (ostream&, PairOfDoubles&);
	
	~PairOfDoubles() { }
};

class PairOfFloats : public PairOfDoubles {
protected:
	float FirstMantissa, SecondMantissa;
	int FirstOrder, SecondOrder;
public:
	PairOfFloats() {
		FirstMantissa = 0;
		FirstOrder = 0;
		SecondMantissa = 0;
		SecondOrder = 0;
	}

	PairOfFloats(float firstMantissa, int firstOrder, float secondMantissa, int secondOrder) {
		FirstMantissa = firstMantissa;
		FirstOrder = firstOrder;
		SecondMantissa = secondMantissa;
		SecondOrder = secondOrder;
	}

	PairOfFloats(int firstIntNumber, double firstFractionalPart, int firstOrder, 
		int secondIntNumber, double secondFractionalPart, int secondOrder) 
		: PairOfDoubles(firstIntNumber, firstFractionalPart, secondIntNumber, secondFractionalPart) {
		FirstMantissa = firstIntNumber + firstFractionalPart;
		FirstOrder = firstOrder;
		SecondMantissa = secondIntNumber + secondFractionalPart;
		SecondOrder = secondOrder;
	}

	~PairOfFloats() { }

	float GetFirstMantissa() {
		return FirstMantissa;
	}

	void SetFirstMantissa(float mantissa) {
		FirstMantissa = mantissa;
	}

	int GetFirstOrder() {
		return FirstOrder;
	}

	void SetFirstOrder(int order) {
		FirstOrder = order;
	}

	float GetSecondMantissa() {
		return SecondMantissa;
	}

	void SetSecondMantissa(float mantissa) {
		SecondMantissa = mantissa;
	}

	int GetSecondOrder() {
		return SecondOrder;
	}

	void SetSecondOrder(int order) {
		SecondOrder = order;
	}

	PairOfFloats CompareNumbers(PairOfFloats& secondPair) {
		if ((this->FirstMantissa * pow(10, FirstOrder) == secondPair.FirstMantissa * pow(10, secondPair.FirstOrder)) &&
			(this->SecondMantissa * pow(10, SecondOrder) == (secondPair.FirstMantissa * pow(10, secondPair.FirstOrder)))) {
			cout << "Pairs are equal\n";
			return *this;
		}

		if (this->FirstMantissa * pow(10, FirstOrder) > secondPair.FirstMantissa* pow(10, secondPair.FirstOrder))
			return *this;

		if ((this->FirstMantissa * pow(10, FirstOrder) == secondPair.FirstMantissa * pow(10, secondPair.FirstOrder))
			&& (this->SecondMantissa * pow(10, SecondOrder) > secondPair.SecondMantissa * pow(10, secondPair.SecondOrder)))
			return *this;

		if (this->FirstMantissa * pow(10, FirstOrder) < secondPair.FirstMantissa * pow(10, secondPair.FirstOrder))
			return secondPair;

		if ((this->FirstMantissa * pow(10, FirstOrder) == secondPair.FirstMantissa * pow(10, secondPair.FirstOrder)) &&
			(this->SecondMantissa * pow(10, SecondOrder) < secondPair.SecondMantissa * pow(10, secondPair.SecondOrder)))
			return secondPair;
	}

	friend istream& operator >> (istream&, PairOfFloats&);
	friend ostream& operator << (ostream&, PairOfFloats&);
};

// Friend function to input for PairOfIntegers pair.
istream& operator >> (istream& in, PairOfIntegers& pair) {
	in >> pair.FirstIntegerNumber >> pair.SecondIntegerNumber;
	return in;
}

// Overriding friend function to input for PairOfDoubles pair.
istream& operator >> (istream& in, PairOfDoubles& pair) {
	in >> pair.FirstIntegerNumber >> pair.FirstFractionalPart >> pair.SecondIntegerNumber >> pair.SecondFractionalPart;
	return in;
}

// Friend function to input for PairOfFloats pair.
istream& operator >> (istream& in, PairOfFloats& pair) {
	in >> pair.FirstMantissa >> pair.FirstOrder >> pair.SecondMantissa >> pair.SecondOrder;
	return in;
}

// Friend function to output for PairOfIntegers pair.
ostream& operator << (ostream& out, PairOfIntegers& pair) {
	out << "First Integer Number = " << pair.FirstIntegerNumber << endl << "Second Integer Number = " << pair.SecondIntegerNumber << endl;
	return out;
}

// Overriding friend function to output for PairOfDoubles pair.
ostream& operator << (ostream& out, PairOfDoubles& pair) {
	out << "First Double Number = " << pair.FirstIntegerNumber + pair.FirstFractionalPart << endl 
		<< "Second Double Number = " << pair.SecondIntegerNumber + pair.SecondFractionalPart << endl;
	return out;
}

// Overriding friend function to output for PairOfFloats pair.
ostream& operator << (ostream& out, PairOfFloats& pair) {
	out << "First Float Number = " << pair.FirstMantissa << " * 10^" << pair.FirstOrder << endl
		<< "Second Float Number = " << pair.SecondMantissa << " * 10^" << pair.SecondOrder << endl;
	return out;
}

int main() {
	PairOfIntegers pInt = PairOfIntegers(2, 5);
	PairOfDoubles pDouble = PairOfDoubles(4, 0.4, 5, 0.6);
	PairOfFloats pFloat = PairOfFloats(3, -3, 5, -2);

	PairOfIntegers pairsInt[2];
	PairOfDoubles pairsDouble[2];
	PairOfFloats pairsFloat[2];

	pairsInt[0] = PairOfIntegers(1, 1);
	pairsInt[1] = PairOfIntegers(pInt);
	pairsDouble[0] = PairOfDoubles();
	pairsDouble[1] = PairOfDoubles(pDouble);
	pairsFloat[0] = PairOfFloats();
	pairsFloat[1] = PairOfFloats(pFloat);

	PairOfIntegers p1 = pairsInt[0].CompareNumbers(pairsInt[1]);
	PairOfDoubles p2 = pairsDouble[0].CompareNumbers(pairsDouble[1]);
	PairOfFloats p3 = pairsFloat[0].CompareNumbers(pairsFloat[1]);

	cout << p1 << endl;
	cout << p2 << endl;
	cout << p3 << endl;

	return 0;
}