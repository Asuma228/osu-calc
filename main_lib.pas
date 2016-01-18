unit main_lib;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ActnList, ExtCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    Edit1: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label5: TLabel;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    procedure Edit1Change(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

  {Scores}
  Tcurrent=object
    score:real;
    scorestr:string;
    level:integer;
    levelstr: string;
    scores: array[1..500] of currency;
    procedure init_score(cs:real);
    procedure init_scorestr(csstr:string);
    procedure init_lvl(lvl:integer);
    procedure init_lvlstr(lvlstr:string);
    procedure init_scores(scrs:currency;index:word);
  end;

  Tneeded=object
   score:real;
   scorestr:string;
   percent:real;
   procedure init_score(nds:real);
   procedure init_scorestr(ndsstr:string);
   procedure init_pcnt(pcnt:real);
  end;

var
  Form1: TForm1;
  current:Tcurrent;
  needed:Tneeded;
  register:byte;

implementation

{$R *.lfm}


  procedure tcurrent.init_score(cs:real);
  begin
    score:=cs;
  end;
  procedure tcurrent.init_scores(scrs:currency;index:word);
    begin
     scores[index]:=scrs;
    end;
  procedure tcurrent.init_lvl(lvl:integer);
  begin
    level:=lvl;
  end;
  procedure tcurrent.init_lvlstr(lvlstr:string);
   begin
     levelstr:=lvlstr;
   end;
  procedure tcurrent.init_scorestr(csstr:string);
   begin
    scorestr:=csstr;
   end;
  procedure tneeded.init_score(nds:real);
   begin
     score:=nds;
   end;
  procedure tneeded.init_scorestr(ndsstr:string);
   begin
     scorestr:=ndsstr
   end;
  procedure tneeded.init_pcnt(pcnt:real);
   begin
     percent:=pcnt;
   end;

    { TForm1 }

procedure TForm1.Edit1Change(Sender: TObject);

 var
  i,lngth,lngth_div,j:integer;
begin


  current.init_scorestr('');
  current.init_score(0);
  current.init_lvl(1);
  needed.init_score(0);
  current.init_lvlstr('');
  label5.caption:='';

  if radiobutton1.Checked=true then
  begin
  current.init_scorestr(edit1.text);
  if current.scorestr='' then current.scorestr:='0';
  register:=1;
  while register=1 do
  begin
  for i:=1 to length(current.scorestr) do
   begin
     if (current.scorestr[i]<>'0')
       and (current.scorestr[i]<>'1')
       and (current.scorestr[i]<>'2')
       and (current.scorestr[i]<>'3')
       and (current.scorestr[i]<>'4')
       and (current.scorestr[i]<>'5')
       and (current.scorestr[i]<>'6')
       and (current.scorestr[i]<>'7')
       and (current.scorestr[i]<>'8')
       and (current.scorestr[i]<>'9')
      then
       begin
        delete(current.scorestr,i,1);
        register:=1;
       end else register:=0;
   end;
  end;
  current.init_score(strtofloat(current.scorestr));

  current.init_scores(0,1);
  for i:=2 to 500 do
   begin
       case i of
         2..100:current.scores[i]:=5000/3*(4*(i*i*i)-3*sqr(i)-i)+1.25*(exp((i-60)*ln(1.8)));
         101..500:current.scores[i]:=26931190829+100000000000*(i-100);
       end;
     if current.score>=current.scores[i] then current.init_lvl(i);
   end;

      current.init_lvlstr(inttostr(current.level));
      needed.init_score(current.scores[current.level+1]-current.score);


      needed.init_pcnt(needed.score/(current.scores[current.level+1]-current.scores[current.level])*100);

      needed.init_scorestr(floattostrf(needed.score,fffixed,12,0));
      lngth:=length(needed.scorestr);
      lngth_div:=lngth div 3;

       j:=0;
       for i:=lngth downto 1 do
        begin
          j:=j+1;
          if j mod 3 = 0 then insert('.',needed.scorestr,i)
        end;
       if needed.scorestr[1]='.' then delete(needed.scorestr,1,1);

  if needed.score<0 then
    begin
      label2.caption:='Ошибка!';
      label3.caption:='Вы ввели количество очков большее, чем на 500 уровне.';
      label5.caption:='Повторите ввод.'
    end
    else
      begin
      label2.Caption:='Ваш уровень: '+current.levelstr;
      label3.Caption:='До следующего уровня осталось: '+needed.scorestr+' очков или '+floattostrf(needed.percent,fffixed,2,3)+'% от текущего';
    end;
    end else
    begin
      current.init_lvlstr(edit1.Text);
      if current.levelstr='' then current.levelstr:='0';
       register:=1;
  while register=1 do
  begin
  for i:=1 to length(current.levelstr) do
   begin
     if (current.levelstr[i]<>'0')
       and (current.levelstr[i]<>'1')
       and (current.levelstr[i]<>'2')
       and (current.levelstr[i]<>'3')
       and (current.levelstr[i]<>'4')
       and (current.levelstr[i]<>'5')
       and (current.levelstr[i]<>'6')
       and (current.levelstr[i]<>'7')
       and (current.levelstr[i]<>'8')
       and (current.levelstr[i]<>'9')
      then
       begin
        delete(current.levelstr,i,1);
        register:=1;
       end else register:=0;
   end;
  end;
      current.init_lvl(strtoint(current.levelstr));

      for i:=2 to 500 do

         begin
           case i of
             2..100:current.scores[i]:=5000/3*(4*(i*i*i)-3*sqr(i)-i)+1.25*(exp((i-60)*ln(1.8)));
             101..500:current.scores[i]:=26931190829+100000000000*(i-100);
           end;
           if current.level=i then current.init_score(current.scores[i-1]);
         end;

        needed.init_score(current.scores[current.level+1]-current.score);
        needed.init_scorestr(floattostrf(needed.score,fffixed,12,0));
        lngth:=length(needed.scorestr);
        lngth_div:=lngth div 3;

        j:=0;
        for i:=lngth downto 1 do
         begin
           j:=j+1;
           if j mod 3 = 0 then insert('.',needed.scorestr,i)
         end;
      if needed.scorestr[1]='.' then delete(needed.scorestr,1,1);
        label2.Caption:='Ваш уровень: '+current.levelstr;
        current.init_lvlstr(inttostr(current.level+1));
        label3.Caption:='До следующего уровня ('+current.levelstr+'-го) осталось: '+needed.scorestr+' очков от текущего';

    end;
end;
end.

