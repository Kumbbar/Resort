   M S B A M L   `   `   `  ????A  =resort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:resort.Windowsresort.Windows  5   	        resort.Windows.HotelWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:resort.Windows     5   	     ? Title$-  'Редактирование отеля??5   	   $	??450??6&   $	??300??63   $	??450??6?   $	??300??6O    ? 
ResizeMode$ NoResize=?5	   	   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      $??3* ?6   ?? 5      $??7* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??0??6   $??Название: ??6-   $??Right=?6B   $??Center=?6^   ?? 5   
   $??1??6   $??0??6   $??К-во звезд: ??6-   $??Right=?6D   $??Center=?6`   ?? 5   
   $??2??6   $??0??6   $??Страна: ??6-   $??Right=?6@   $??Center=?6\   ?? 5   
   -   5         ??Name$ TxtName??5      $??0??6#   $	??200??60   $??1??6<   $??Center=?6L   $
??Left=?6g   ?? 5   
   -   5        $ TxtStars??5      $??1??6$   $	??200??61   $??1??6=   $??Center=?6M   $
??Left=?6h   ?? 5   
   -   5         ??Name$ 
CmbCountry??5      $??2??6'   $??2??64   $??Center=?6D    ?? DisplayMemberPath$
 Name??6_   6x   ?? 5   
   -   5         ??Name$ BtnDel??5      $??4??6!   $??0??6.   $??Удалить??6>   6P   ?? 5    
   -   5        $ BtnSave??5       $??1??6"   $??4??62   $??Сохранить??6?   6S   5!      5"      