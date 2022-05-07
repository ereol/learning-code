function bmatch = findmatch(data)
    bmatch = -1;
    for i = 1 :length(data)-1
        for j = i+1:length(data)
            if data(i) == data(j)
                bmatch = 1;
            end 
        end 
    end 
    if(bmatch == -1)
        bmatch = 0;
    end 
end 
