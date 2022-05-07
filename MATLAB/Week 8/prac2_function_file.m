function finalImage = prac2_function_file(x, image1)

[row,column,~]= size(image1);

switch x
    case 'r'
        for i = 1:row
            for j= 1:column
                red=image1(i,j,1);
                green=image1(i,j,2);
                blue=image1(i,j,3);
                  if (red>170&& green < 120 && blue<140)
                    image1(i,j,1)=0;
                    image1(i,j,2)=0;
                    image1(i,j,3)=0;
                 end
            end

        end
    case 'g'
         for i = 1:row
            for j= 1:column
                red=image1(i,j,1);
                green=image1(i,j,2);
                blue=image1(i,j,3);
                  if (red<100 && green > 115 && blue<130)
                    image1(i,j,1)=0;
                    image1(i,j,2)=0;
                    image1(i,j,3)=0;
                  end
            end
         end
    case 'b'
         for i = 1:row
            for j= 1:column
                red=image1(i,j,1);
                green=image1(i,j,2);
                blue=image1(i,j,3);
                  if (red<127&& green < 127 && blue>127)
                    image1(i,j,1)=0;
                    image1(i,j,2)=0;
                    image1(i,j,3)=0;
                  end
            end
         end
     case 'y'
         for i = 1:row
            for j= 1:column
                red=image1(i,j,1);
                green=image1(i,j,2);
                blue=image1(i,j,3);
                  if (red>135 && green > 170 && blue<100)
                    image1(i,j,1)=0;
                    image1(i,j,2)=0;
                    image1(i,j,3)=0;
                  end
            end
         end
   
  case 'c'
         for i = 1:row
            for j= 1:column
                red=image1(i,j,1);
                green=image1(i,j,2);
                blue=image1(i,j,3);
                  if (red<127 && green > 127 && blue>127)
                    image1(i,j,1)=0;
                    image1(i,j,2)=0;
                    image1(i,j,3)=0;
                  end
            end
         end
     case 'm'
         for i = 1:row
            for j= 1:column
                red=image1(i,j,1);
                green=image1(i,j,2);
                blue=image1(i,j,3);
                  if (red>127 && green < 127 && blue>127)
                    image1(i,j,1)=0;
                    image1(i,j,2)=0;
                    image1(i,j,3)=0;
                  end
            end
         end
    otherwise
        disp('incorrect election')
end


finalImage = image1;