import { UnisolutionTemplatePage } from './app.po';

describe('Unisolution App', function() {
  let page: UnisolutionTemplatePage;

  beforeEach(() => {
    page = new UnisolutionTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
