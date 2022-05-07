function dates = birthdayGUI(N,S)
    run = 0;
    dates = zeros(N,1);
    for k = 1:N
        while run < S
        dates(k) = randi(N,1);
        run = run + 1;
        end
    end
end











