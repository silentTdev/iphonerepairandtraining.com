class Animal {
    species: string;

    constructor(species: string) {
        this.species = species;
    }

    speak()
    {
        $.each($('.class'), function ()
        {
            $(this).val('');
        });
        alert('I am a ss' + this.species);
    }
}