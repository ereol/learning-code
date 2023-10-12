def numberSorter(note):
    print('Total number of rows: '+str(note.max_row)+'. And total number of columns: '+str(note.max_column))

    i = 1
    f = 1
    x = 0

    for f in range(1,note.max_column):
        for i in range(1,note.max_row):
            x+=note.cell(row=i,column=f).value

            i+=1
        f+=1

    x /= (note.max_row * note.max_column)
    return(x)


