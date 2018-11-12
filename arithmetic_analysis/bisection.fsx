let rec bisection(func: float -> float) (a: float)(b: float) = 
    if (func(a) = 0.0) then
        a
    elif (func(b) = 0.0) then
        b
    elif (func(a) * func(b) > 0.0) then
        printf "Could not find root in [a, b]"
        0.0
    else
        let mid = (a + b) / 2.0
        while abs(a - mid) > 10.0 ** -7 do
            if (func mid = 0.0) then
                mid
            elif (func mid * func a = 0.0) then
                
