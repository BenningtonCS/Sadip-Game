using System;

namespace Triangle
{
	class MainClass
	{
		const string asterik = "*";
		const string space = " ";
		const int sizeOfTriangle = 5;

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			DrawRightTriangle(sizeOfTriangle);
			Console.WriteLine ();
			DrawLeftTriangle (sizeOfTriangle);
			Console.WriteLine ();
			DrawRightInvertedTriangle (sizeOfTriangle);
			Console.WriteLine ();
			DrawLeftInvertedTriangle (sizeOfTriangle);
			Console.WriteLine ();
			DrawEquilateralTriangle(sizeOfTriangle);
			Console.WriteLine ();
			DrawInvertedEquilateralTriangle (sizeOfTriangle);
			Console.WriteLine ();
			DrawDiamondTriangle (sizeOfTriangle);
		}



		// to print this triangle which is named as draw right triangle 
		/*
			*
			**
			***
			****
			*****

		*/
		static void DrawRightTriangle(int size) {
			for(int numberOfRows = 1; numberOfRows <= size; numberOfRows++) {
				
				//for printing asteriks whose number is equal to the number of rows 
				for(int numberOfColumns = 1; numberOfColumns <= numberOfRows; numberOfColumns++){
					Console.Write (asterik);
				}
				//and then changing the row that is changing the line
				Console.WriteLine ();
			}
		}



		// to print this triangle which is named as draw left triangle 
		/*
			    *
			   **
			  ***
			 ****
			*****

		*/
		static void DrawLeftTriangle(int size){
			for(int numberOfRows = 1; numberOfRows <= size; numberOfRows++) {

				//for printing the spaces first 
				for(int numberOfColumns = size; numberOfColumns >= numberOfRows; numberOfColumns--){
					Console.Write (space);
				}

				//for printing asterik after spacing these by printing the spaces
				for (int numberOfColumns = 1; numberOfColumns <= numberOfRows; numberOfColumns++) {
					Console.Write (asterik);
				}

				//and then changing the row that is changing the line
				Console.WriteLine ();
			}
		}



		// to print this triangle which is named as draw right inverted triangle 
		/*
			*****
			****
			***
			**
			*
		*/
		static void DrawRightInvertedTriangle(int size) {
			for(int numberOfRows = 1; numberOfRows <= size; numberOfRows++) {

				//printing asteriks first
				for(int numberOfColumns = size; numberOfColumns >= numberOfRows; numberOfColumns--){
					Console.Write (asterik);
				}

				//and then changing the row that is changing the line
				Console.WriteLine ();
			}
		}



		// to print this triangle which is named as draw left inverted triangle 
		/*
			*****
			 ****
			  ***
			   **
			    *
		*/
		static void DrawLeftInvertedTriangle(int size) {
			for(int numberOfRows = 1; numberOfRows <= size; numberOfRows++) {

				//printing the spaces first
				for(int numberOfColumns = 1; numberOfColumns <= numberOfRows; numberOfColumns++){
					Console.Write (space);
				}

				//and then printing the asteriks
				for(int numberOfColumns = size; numberOfColumns >= numberOfRows; numberOfColumns--){
					Console.Write (asterik);
				}

				//now changing the row that is changing the line
				Console.WriteLine ();
			}
		}



		// to print this triangle which is named as draw equilateral triangle 
		/*
			     *
			    ***
			   *****
			  *******
			 *********
		*/
		static void DrawEquilateralTriangle(int size){
			for(int numberOfRows = 1; numberOfRows <= size; numberOfRows++){
				
				//for printing the spaces first
				for(int numberOfColumns = size; numberOfColumns >= numberOfRows; numberOfColumns--){
					Console.Write (space);
				}

				//and then printing the asteriks where the number of asteriks is equal to (2*numberOfRows - 1)
				for(int numberOfColumns = 1; numberOfColumns <= (2 * numberOfRows - 1); numberOfColumns++){
					Console.Write (asterik);
				}

				//and then changing the line that is changing the line
				Console.WriteLine ();
			}
		}



		// to print this triangle which is named as draw inverted equilateral triangle 
		/*
			*********
			 *******
			  *****
			   ***
			    *
		*/
		static void DrawInvertedEquilateralTriangle(int size){
			for(int numberOfRows = 1; numberOfRows <= size; numberOfRows++){

				//for printing the spaces first
				for(int numberOfColumns = 1; numberOfColumns <= numberOfRows; numberOfColumns++){
					Console.Write (space);
				}

				//and then printing the asteriks where the number of asteriks is equal to (2*numberOfRows - 1)
				for(int numberOfColumns = (2 * size-1); numberOfColumns >= (2 * numberOfRows - 1); numberOfColumns--){
					Console.Write (asterik);
				}

				//and then changing the line that is changing the line
				Console.WriteLine ();
			}
		}



			// to print this triangle which is named as diamond triangle 
			/*
			     *
			    ***
			   *****
			  	***
			 	 *
		*/
		
		static void DrawDiamondTriangle(int size){

			//at first printing the upper equilateral triangle which is similar to our previous equilateral function
			for (int numberOfRows = 1; numberOfRows <= size; numberOfRows++) {

				//printing for spaces at first
				for (int numberOfColumns = size; numberOfColumns >= numberOfRows; numberOfColumns--) {
					Console.Write (space);
				}

				//printing for asteriks where the number of asteriks is equal to (2*numberOfRows - 1)
				for (int numberOfColumns = 1; numberOfColumns <= (2 * numberOfRows - 1); numberOfColumns++) {
					Console.Write (asterik);
				}

				//now changing the row that is changing the line
				Console.WriteLine ();

			}

				//similarly now printing out the inverted equilateral triangle which is the lateral part of the diamond and is similar to our previous inverted equilateral triangle
				for(int numberOfRow = 1; numberOfRow <= size; numberOfRow++){

					//printing the spaces at first 
					for(int numberOfColumns = 1; numberOfColumns <= numberOfRow; numberOfColumns++){
						Console.Write (space);
					}
						
					//now printing the asteriks where the number of asterik starts from (2*size - 1) and goes on following the same condition of (2*numberOfRows - 1)
					for(int numberOfColumns = (2 * size - 1); numberOfColumns >= (2 * numberOfRow -1); numberOfColumns--){
						Console.Write (asterik);
					}

				//now changing the row that is changing the line
				Console.WriteLine();

				}
		}
	}
}