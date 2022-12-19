'''
You will be given an array of non-negative integers and positive integer bin width.

Your task is to create the Histogram method that will return histogram data corresponding to the input array. The histogram data is an array that stores under index i the count of numbers that belong to bin i. The first bin always starts with zero.

On empty input you should return empty output.

You're making a histogram from a set of data. It's a bar graph of "bins" (ranges) of numbers vs. their frequency in the set. The return value is the heights of the columns in the histogram.

For the data [1, 1, 0, 1, 3, 2, 6], binWidth = 1 in the example, there is one 0, three 1s, one 2, one 3, no 4s, no 5s and one 6, so the output will be [1, 3, 1, 1, 0, 0, 1] -- the frequencies of each element for all the possible bins. Each bin just contains a single number.
'''


def histogram(values, bin_width):   
    if (len(values) == 0):
        return []
    
    m = []
    for i in range(max(values) +1):
        m.append(sum(1 for v in values if v == i))
        
    m2 = []    
    for i in range(0, len(m), bin_width):
        s = 0
        for j in range(0, bin_width):
            if (i+j) < len(m):
                s = s + m[i+j]
        m2.append(s)        
        
    return m2