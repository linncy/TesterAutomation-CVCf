import csv
import visa
from time import ctime,sleep
import time
rm = visa.ResourceManager()
try:
    lcr4284a = rm.open_resource('GPIB0::25::INSTR')
except:
    try:
        lcr4284a = rm.open_resource('GPIB1::25::INSTR')
    except:
        try:
            lcr4284a = rm.open_resource('GPIB3::25::INSTR')
        except:
            try:
                lcr4284a = rm.open_resource('GPIB3::25::INSTR')
            except:
                print('GPIB Connection Error')
startV=float(input('Start Voltage')) #
stopV=float(input('Stop Voltage'))
stepV=float(input('Step Voltage'))
frequency=input('Frequency (e.g: 100000)')
V=startV
lcr4284a.write("BIAS:STAT 1") #开DC，测CV下要开DC BIAS
lcr4284a.write("VOLT 25MV")
lcr4284a.write("FREQ "+frequency)
print('Start C-V Sweep')
data=[]
while(V<=stopV+stepV):
    lcr4284a.write("BIAS:VOLT %f"%V)
    sleep(0.1)
    fetc=lcr4284a.query("FETC?")
    data.append([V,fetc[:12]])
    V=V+stepV
with open("Cf%s.csv"%time.strftime('%Y%m%d%H%M%S',time.localtime(time.time())),"w", newline='') as datacsv:
    csvwriter = csv.writer(datacsv,dialect=("excel"))
    csvwriter.writerow(["BIAS(V)","C(F)"])
    for i in range(len(data)):
        csvwriter.writerow([data[i][0],data[i][1]])
print('Successfully Saved')