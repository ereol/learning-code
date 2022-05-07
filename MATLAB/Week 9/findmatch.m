%% Birthday Paradox Module 2 part b
function bmatch = findmatch(data)
    bmatch = -1;
    data = (1:N);
    for j = 1 :length(data)-1
        for i = j+1:length(data)
            if data(j) == data(i)
                bmatch = 1;
            end 
        end 
    end 
    if(bmatch == -1)
        bmatch = 0;
    end 
end 