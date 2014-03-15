using System;

using GigaSpaces.Core;

 
public class SpaceUtility {

	private ISpaceProxy proxy;

	public SpaceUtility(ISpaceProxy proxy)
	{
		this.proxy = proxy;
	}

	public void clear(Object template)
	{
		proxy.Clear(template);
	}
}
