set origin=F:\Repo\Git\mtgDb\out
set images=D:\distrib\games\mtg\Mtgdb.Pictures
set qs=lq mq

rem set sets=war,ss2,htr17
set sets=c19,celd,cmb1,eld,gn2,ha1,hho,peld,ptg,puma

for %%q in (%qs%) do (
    %origin%\bin\debug\Mtgdb.Util.exe -sign %images%\%%q -output %images%\%%q-list\filelist.txt -set %sets%
)
