# IntersectionBetweenTwoPlanes3D
AMC Test task
Description
Suppose we are given two planes in 3D space. Find the intersection between these planes. The planes are specified by the point 
lying on the plane and by its normal vector. The input data are 12 double numbers. The first three numbers are coordinates 
of the point lying on the first plane. The second three numbers are coordinates of the normal vector of the first plane. 
The third three numbers are coordinates of the point lying on the second plane. The last three numbers are coordinates of 
the normal vector of the second plane. Input data guarantees that lengths of normal vectors are greater than 1e-8. 


All input numbers are separated by spaces. Input data guarantees that inputs and the results will be 
less than 9 223 372 036 854 775 807.0. Output data must be: 

1)if the planes don't intersect (are parallel) 
output is integer number 0; 

2)if the planes intersect (intersection is a line) output data is integer number 
2 and coordinates of some point of the line, and coordinates of the normalized direction vector of the line. 
All numbers must be separated by spaces; 

3)if the planes coincide output data is integer number 3 and coordinates 
of some point of the plane, and coordinates of the normalized normal vector of the plane. 


All numbers must be separated by spaces. The result is considered correct if it is correct up 
to 8 decimal places, i. e. two real numbers A and B are considered equal if |A-B|<1e-8

Project code: IntersectionBetweenTwoPlanes3D
Requirements 

Example: 
Input:
1.0 2.0 3.0
1.0 1.0 1.0 
-3.0 9.0 2.0
5.0 5.0 5.0 
Output:
0 


Input:
0.0 0.0 0.0
1.0 0.0 0.0 

3.0 5.0 4.0 
0.0 1.0 0.0 

Output:
2 
0.0 5.0 0.0 
0.0 0.0 1.0 

Input:
4.0 3.0 -2.0 
1.0 10.0 -1.0 
5.0 4.0 9.0 
-10.0 -100.0 10.0 
Output:
3 
4.0 3.0 -2.0 
0.099014754 0.990147543 -0.099014754
