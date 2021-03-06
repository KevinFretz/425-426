// Rule90.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string.h>
#include <string>
#include <iostream>
#include <stdlib.h>

using namespace std;


int main()
{
	char choice;
	int presentState[31] = { 0,0,0,0,0,0,0,0, 0, 0, 0, 0, 0, 0,0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	int previousState[31];
	int time = 0;

	//cout << "Do you want to have an infinite array or a finite array?" << endl;

	cout << "This is rule 90 on a 15 cell array." << endl;
	cout << "Do you want to enter the starting state? (Y/N)" << endl;
	cin >> choice;

	if (choice == 'Y' || choice == 'y')
	{
		for (int i = 0; i < 31; i++)
		{
			cout << "Enter in the value for cell number " << i << " (0 or 1)" << endl;
			cin >> presentState[i];
		}
	}
	int p, n;
	for (int i = 0; i<31; i++) {
		if (presentState[i] == 0) {
			cout << "  ";
		}
		else {
			cout << "X ";
		}
	}
	cout << endl;
	while (time < 16) {
		for (int i = 0; i < 31; i++) {
			previousState[i] = presentState[i];
		}
		for (int i = 0; i < 31; i++) {
			p = i - 1;
			n = i + 1;
			if (p == -1 && previousState[n] == 1) {
				presentState[i] = 1;
			}
			else if (p == -1 && previousState[n] == 0) {
				presentState[i] = 0;
			}
			else if (n == 31 && previousState[p] == 1) {
				presentState[i] = 1;
			}
			else if (n == 31 && previousState[p] == 0) {
				presentState[i] = 0;
			}
			else if (previousState[n] == 1 && previousState[p] == 0) {
				presentState[i] = 1;
			}
			else if (previousState[n] == 0 && previousState[p] == 0) {
				presentState[i] = 0;
			}
			else if (previousState[n] == 1 && previousState[p] == 1) {
				presentState[i] = 0;
			}
			else if (previousState[n] == 0 && previousState[p] == 1) {
				presentState[i] = 1;
			}
		}
		for (int i = 0; i < 31; i++)
		{
			if (presentState[i] == 0) {
				cout << "  ";
			}
			else {
				cout << "X ";
			}
		}
		cout << endl;
		time++;
	}
	cout << endl;


    return 0;
}

