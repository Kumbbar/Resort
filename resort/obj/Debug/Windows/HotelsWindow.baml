   M S B A M L   `   `   `  ????A  =resort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:resort.Windowsresort.Windows  5   	   !    resort.Windows.HotelsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:resort.Windows     5   	     ? Title$  
Отели??5   	   $	??450??6   $	??800??6$   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??9* ?6   ?? 5      $??1* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DtGrHotels??5       $??0??6      AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6b      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ?? *Name+  5      $ К-во звезд??6%    69   ?? *CountOfStars+  5      $ Страна??6%    65   ?? *Country.Name+4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      ?? 5      .R?5      ?? 
 ??Name$
 BtnDtGr??6%   -   5        $ ??Редактировать??5   L   5      5      5      ?? 5   
   $??1??6    ?? Orientation$ 
Horizontal=?6"   $??Center=?6;   .+?5      ?? -   5        $
 BtnFirst??5      $??35??6'   $??30??63   $??5 0 5 0q?6>   $??<<??6O   6b   ?? 5      -   5        $
 BtnPrevious??5      $??35??6*   $??30??66   $??5 0 5 0q?6A   $??<??6R   6a   ?? 5      $ Vertical=?6   $??35??60   .+?5       ?? -   5         ??Name$ 
TxtNumPage??5       $??20??6.   $??30??6:    ?? TextAlignment$ Center=?6E   ?? 5!      -   5         ??Name$ 	LbNumPage??5!      $??1 of 5??6+   $??15??6<   $??0q?6H   5"      ?? 5#      -   5        $
 BtnNext??5#      $??35??6&   $??30??62   $??5 0 5 0q?6=   $??>??6N   6Z   ?? 5$      -   5        $
 BtnLast??5$      $??35??6&   $??30??62   $??5 0 5 0q?6=   $??>>??6N   6[   5%      ?? 5&   
   -	   5        $
 BtnCreateHotel??5&      $??1??6   $??35??66   $??70??6B   $??Right=?6M   $??0 0 5 0q?6i   $??Создать??6z   6?   5(      5)      