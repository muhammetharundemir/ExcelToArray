# ExcelToArray
Excel data is converted to array. (C++, C#)

First data of every column becomes array name. The remaining data becomes an array data.

Example:

Excel data >> Earth     Mars      Pluto
              9.807     3.721     0.62
              6371      3389.5    1188.3
              7.753       0         0
              
C array txt data >> double[] Earth = { 9.807, 6371, 7.753 }
                    double[] Mars = { 3.721, 3389.5, 0 }
                    double[] Pluto = { 0.62, 1188.3, 0 }
