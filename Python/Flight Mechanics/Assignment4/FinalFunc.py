def Calculation(notes):
    import ExcelSorter as ExS
    qinf = (1/2)*1.225*20
    S_tail = 0.014
    c_root = 125/1000
    c_tip = 94/1000


    for count, value in enumerate(notes):

        x = ExS.numberSorter(value)
        print("Sheet " + str((-1/3)*(count+1)+7) + "\nDrag: [" + str(x[0]) + " N]\nPitching Moment: [" + str(x[1]) + " N]\nDrag reducted from Sting: [" + str(x[2]) + " N]")
        print("C_M: [" + (str(x[1]/(qinf*S_tail*c_root)))+"]\n")
        #print('Total number of rows: '+str(value.max_row)+'. And total number of columns: '+str(value.max_column) +"\n")
