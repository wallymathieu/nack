//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4.1.9004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4.1.9004 .\\find\\SearchExpr.g 2012-12-26 17:27:36

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

namespace  find 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4.1.9004")]
[System.CLSCompliant(false)]
public partial class SearchExprLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int MATCH=4;
	public const int QUESTION=5;
	public const int STAR=6;

    // delegates
    // delegators

	public SearchExprLexer()
	{
		OnCreated();
	}

	public SearchExprLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public SearchExprLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return ".\\find\\SearchExpr.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_STAR();
	partial void LeaveRule_STAR();

	// $ANTLR start "STAR"
	[GrammarRule("STAR")]
	private void mSTAR()
	{
		EnterRule_STAR();
		EnterRule("STAR", 1);
		TraceIn("STAR", 1);
		try
		{
			int _type = STAR;
			int _channel = DefaultTokenChannel;
			// .\\find\\SearchExpr.g:21:5: ( '*' )
			DebugEnterAlt(1);
			// .\\find\\SearchExpr.g:21:6: '*'
			{
			DebugLocation(21, 6);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STAR", 1);
			LeaveRule("STAR", 1);
			LeaveRule_STAR();
		}
	}
	// $ANTLR end "STAR"

	partial void EnterRule_QUESTION();
	partial void LeaveRule_QUESTION();

	// $ANTLR start "QUESTION"
	[GrammarRule("QUESTION")]
	private void mQUESTION()
	{
		EnterRule_QUESTION();
		EnterRule("QUESTION", 2);
		TraceIn("QUESTION", 2);
		try
		{
			int _type = QUESTION;
			int _channel = DefaultTokenChannel;
			// .\\find\\SearchExpr.g:22:9: ( '?' )
			DebugEnterAlt(1);
			// .\\find\\SearchExpr.g:22:10: '?'
			{
			DebugLocation(22, 10);
			Match('?'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("QUESTION", 2);
			LeaveRule("QUESTION", 2);
			LeaveRule_QUESTION();
		}
	}
	// $ANTLR end "QUESTION"

	partial void EnterRule_MATCH();
	partial void LeaveRule_MATCH();

	// $ANTLR start "MATCH"
	[GrammarRule("MATCH")]
	private void mMATCH()
	{
		EnterRule_MATCH();
		EnterRule("MATCH", 3);
		TraceIn("MATCH", 3);
		try
		{
			int _type = MATCH;
			int _channel = DefaultTokenChannel;
			// .\\find\\SearchExpr.g:23:6: ( (~ ( '*' | '?' ) )+ )
			DebugEnterAlt(1);
			// .\\find\\SearchExpr.g:23:8: (~ ( '*' | '?' ) )+
			{
			DebugLocation(23, 8);
			// .\\find\\SearchExpr.g:23:8: (~ ( '*' | '?' ) )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if (((LA1_1>='\u0000' && LA1_1<=')')||(LA1_1>='+' && LA1_1<='>')||(LA1_1>='@' && LA1_1<='\uFFFF')))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// .\\find\\SearchExpr.g:
					{
					DebugLocation(23, 8);
					input.Consume();


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MATCH", 3);
			LeaveRule("MATCH", 3);
			LeaveRule_MATCH();
		}
	}
	// $ANTLR end "MATCH"

	public override void mTokens()
	{
		// .\\find\\SearchExpr.g:1:8: ( STAR | QUESTION | MATCH )
		int alt2=3;
		try { DebugEnterDecision(2, false);
		int LA2_1 = input.LA(1);

		if ((LA2_1=='*'))
		{
			alt2 = 1;
		}
		else if ((LA2_1=='?'))
		{
			alt2 = 2;
		}
		else if (((LA2_1>='\u0000' && LA2_1<=')')||(LA2_1>='+' && LA2_1<='>')||(LA2_1>='@' && LA2_1<='\uFFFF')))
		{
			alt2 = 3;
		}
		else
		{
			NoViableAltException nvae = new NoViableAltException("", 2, 0, input, 1);
			DebugRecognitionException(nvae);
			throw nvae;
		}
		} finally { DebugExitDecision(2); }
		switch (alt2)
		{
		case 1:
			DebugEnterAlt(1);
			// .\\find\\SearchExpr.g:1:10: STAR
			{
			DebugLocation(1, 10);
			mSTAR(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// .\\find\\SearchExpr.g:1:15: QUESTION
			{
			DebugLocation(1, 15);
			mQUESTION(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// .\\find\\SearchExpr.g:1:24: MATCH
			{
			DebugLocation(1, 24);
			mMATCH(); 

			}
			break;

		}

	}


	#region DFA

	protected override void InitDFAs()
	{
		base.InitDFAs();
	}

 
	#endregion

}

} // namespace  find 