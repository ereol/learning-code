

function dates = dategen(N)
    month = randi(12,N,1);
    day = zeros(N,1);
    for i = 1:1:N
        if month(i) == 2
            day(i) = randi(28,1,1);
        elseif month (i) == 1 || month(i) == 3 || month(i) == 5 || month(i) == 7 || month(i) == 8 || month(i) == 10 || month(i) == 12
            day(i) = randi(31,1,1);
        else 
            day(i) = randi(30,1,1);
        end
    end
    dates = [day,month];
end
