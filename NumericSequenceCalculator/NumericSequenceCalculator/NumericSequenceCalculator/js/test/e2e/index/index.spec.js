/*
 * Numeric Sequence Test - Protractor - using jasmine for spec
 * 
 * describe inside describe indicates more specific tests
 * it > test action
 */


describe( 'hello-protractor', function () {
    browser.ignoreSynchronization = true;

    //Home page tests
    describe( "index", function () {

        beforeEach( function () {
            //Go to homepage
            browser.get( '/home/index' );

            //Enter a number
            numberInput.sendKeys( '10' );

            //Calculate sequences
            calculateBtn.click();
        } );


        //Initialize variables
        var numberInput = element( by.model( 'number' ) );
        var numberBinding = element( by.binding( 'number' ) );  //Cannot find binding inside form
        var calculateBtn = element( by.id( 'calculateBtn' ) );

        var defaultSequence = element.all( by.repeater( 'item in sequences.all' ) );
        var oddSequence = element.all( by.repeater( 'item in sequences.odd' ) );
        var evenSequence = element.all( by.repeater( 'item in sequences.even' ) );
        var conditionalSequence = element.all( by.repeater( 'item in sequences.conditional' ) );
        var fibonacciSequence = element.all( by.repeater( 'item in sequences.fibonacci' ) );

      
        //Check title
        it( '#1 correct title', function () {
            expect( browser.getTitle() ).toEqual( 'Home Page' );
        } );

        //Check number binding
        it( '#2 change number and view the output', function () {
            //Get binding and check its value
            expect( numberBinding.getText() ).toEqual( '10' );
        } );

        //All numbers sequence
        it( '#3 should return valid number sequence', function () {
            expect( defaultSequence.count() ).toEqual( 11 );
            expect( defaultSequence.last().getText() ).toEqual( '10' );
        } );

        //Odd numbers sequence
        it( '#4 should return valid odd number sequence', function () {
            expect( oddSequence.count() ).toEqual( 5 );
            expect( oddSequence.last().getText() ).toEqual( '9' );   
        } );

        //Even numbers sequence
        it( '#5 should return valid even number sequence', function () {
            expect( evenSequence.count() ).toEqual( 6 );
            expect( evenSequence.last().getText() ).toEqual( '10' );   
        } );

        //Conditional result sequence
        it( '#6 should return valid conditional sequence', function () {
            expect( conditionalSequence.count() ).toEqual( 1 );
            expect( conditionalSequence.first().getText() ).toEqual( 'E' );
        } );

        //Fibonacci sequence
        it( '#7 should return valid fibonacci sequence', function () {
            expect( fibonacciSequence.count() ).toEqual( 7 );
            expect( fibonacciSequence.first().getText() ).toEqual( '0' );   
        } );
    } );

} );
