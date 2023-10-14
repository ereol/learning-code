def Calculation(notes):
    import ExcelSorter as ExS
    qinf = (0.5)*1.225*35**2
    S_tail = 0.014
    S_wing = 0.05425
    c_root = 125/1000
    c_tip = 94/1000
    h = 0.705
    m = 0

    for count, value in enumerate(notes):

        x = ExS.numberSorter(value)
        print("Sheet " + str(count+1) + "\nDrag: [" + str(x[0]) + " N]\nPitching Moment: [" + str(x[1]) + " N]\nDrag reducted from Sting: [" + str(x[2]) + " N]\nSting: [" + str(x[3]) +" N]")
        m = x[1]-(x[0]-x[3])*h-x[3]*(h/2)
        print("M: ["+str(m)+" N/m]\nC_M: [" + str(m/(qinf*S_wing*((c_root+c_tip)/2)))+" (s^-2)]\n")
        #print('Total number of rows: '+str(value.max_row)+'. And total number of columns: '+str(value.max_column) +"\n")
