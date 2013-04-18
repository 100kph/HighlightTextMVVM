namespace HighlightTextMVVM
{
    using System.Windows;
    using SearchViewModel = HighlightTextMVVM.ViewModel.ViewModel;

    public partial class MainWindow : Window
    {
        private SearchViewModel vm = new SearchViewModel();

        public MainWindow()
        {
            DataContext = vm;
            InitializeComponent();
            SetText();
        }

        private void SetText()
        {
            vm.SearchResult = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus blandit luctus orci. Aenean dui ante, aliquet vel fringilla a, lacinia eu leo. Maecenas ante est, malesuada eu faucibus sit amet, tincidunt faucibus massa. Etiam non lorem sit amet lacus adipiscing blandit non ut tortor. Quisque tempor convallis nunc eget interdum. Aliquam erat volutpat. Donec faucibus erat quis lorem congue sollicitudin. Mauris sit amet consectetur lacus. Aliquam erat volutpat. Integer ultricies sem vel turpis volutpat ac gravida lacus tincidunt. Maecenas fermentum felis id elit sagittis eget convallis ipsum sodales. Morbi et lectus id est pulvinar sodales. Cras feugiat fringilla magna. Nullam sit amet turpis dui, in interdum nibh. Nulla facilisi.

Donec eu nulla in augue accumsan dignissim. In quis lectus elit, in placerat justo. Praesent eu purus sem. Donec eu diam non purus vehicula tincidunt et sit amet purus. Nunc interdum, nisl vitae feugiat cursus, lectus urna congue erat, eget commodo ante purus non felis. Proin nisl nisi, rhoncus id feugiat in, aliquet nec diam. Integer vel nisi odio, eget sodales ligula.

Curabitur metus ipsum, pharetra non ornare a, placerat id magna. Donec iaculis ante at libero tempor pharetra. Etiam et diam sapien, ac ullamcorper turpis. Nam pretium ante eget eros mattis tempus. Morbi non diam purus. Integer luctus molestie turpis et imperdiet. Duis nunc augue, tempor at posuere vitae, dapibus nec tortor. Suspendisse potenti. Donec id ante in justo aliquet placerat ut sit amet eros.

Integer eu hendrerit lectus. Proin consectetur nisl quis quam dignissim convallis. Sed eu enim eu leo facilisis bibendum. Phasellus posuere ante et nibh feugiat eu consectetur justo cursus. Cras nec pretium nisl. Morbi varius quam non justo volutpat posuere. Etiam eget felis sem, a gravida tellus. Aliquam nec dui eu nunc porttitor lobortis at ut quam. Donec eu arcu sem, at porta risus. Etiam vitae nisi non felis dapibus dapibus.

Morbi fringilla odio in lorem lacinia at tristique velit dictum. Praesent ut turpis ipsum. Ut ac dolor dolor. Proin urna nisi, malesuada vitae facilisis eu, pellentesque vel nulla. Nunc suscipit quam eget ligula viverra sit amet molestie massa posuere. Nam vitae risus neque, eu convallis sapien. Aenean quis erat nec dolor commodo fringilla ac ut leo. Mauris nec neque imperdiet nibh volutpat dignissim et ut magna. Aliquam velit purus, bibendum sed porta ut, facilisis ac felis. Fusce pellentesque, mauris eu aliquet tristique, mauris dolor euismod magna, sit amet sagittis nulla dolor vel augue.

Vestibulum in leo velit, a ultrices enim. Nullam dignissim lectus at lorem ultrices nec tristique velit pellentesque. Fusce adipiscing fermentum gravida. Aenean fringilla erat et sem malesuada euismod. Donec a est vitae eros tincidunt ultricies a et nibh. Morbi ante metus, pharetra sed luctus quis, dictum in est. Nam laoreet tristique orci, vel venenatis risus dapibus pharetra.

Nam id pulvinar erat. Integer scelerisque, turpis vitae laoreet tristique, quam turpis congue neque, non consectetur urna magna quis dolor. Cras est velit, ullamcorper sed mollis eget, hendrerit eu neque. Aliquam ac ante a velit pulvinar auctor sed in lectus. Nam eros felis, convallis sed blandit ac, congue in mi. Sed vel mauris eros. Duis ut mi nisi. Aenean et convallis nulla.

Nulla facilisi. Proin hendrerit interdum commodo. Quisque eu enim mi. Aliquam eget pretium dolor. Ut vel diam tellus, et mollis nisl. Donec laoreet fringilla pulvinar. Curabitur fermentum tristique libero, eu convallis tellus lacinia vel. Aenean venenatis tincidunt ultricies. Maecenas molestie sem gravida ligula consequat vitae sollicitudin mi vehicula. Proin vel ornare nulla. Proin a arcu non nunc rhoncus dictum eu at nisi. Morbi eget sagittis neque. Donec bibendum tempor tristique. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Sed blandit adipiscing elit, ac consequat nulla consectetur nec. Vestibulum ut est in lectus tempor vehicula.

Morbi viverra arcu at arcu elementum a vehicula arcu aliquet. Quisque lobortis hendrerit ante vitae tempor. Quisque in nibh ipsum, vitae rutrum lacus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed volutpat pretium lorem, ut ullamcorper quam dapibus vel. Phasellus mi nisi, tincidunt in fringilla quis, placerat quis risus. Praesent sit amet enim ut nisl cursus bibendum. Praesent quis commodo metus. Duis vel neque velit, id gravida odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec non libero augue. Curabitur venenatis enim a neque condimentum in tincidunt est accumsan. Nunc lobortis porta quam, elementum fringilla lorem placerat in.

Ut dapibus molestie dictum. Maecenas interdum nunc vel magna pulvinar accumsan. Nulla facilisi. Nulla sed nisl vitae enim mollis feugiat et et dolor. Pellentesque aliquam interdum porta. Proin et tortor ac sem sagittis vulputate. Integer eu nulla velit, vel sagittis nisi.";
        }
    }
}
